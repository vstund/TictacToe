import React, { useCallback, useEffect, useState } from "react";

export const useBoard = (onComplete?: () => void) => {
  const [board, setBoard] = useState<string>();
  const [loading, setLoading] = useState(false);

  const getBoard = useCallback(async () => {
    setLoading(true);

    await fetch("/api/board")
      .then((response) => response.text())
      .then((result) => {
        console.log("result", result);
        setBoard(result);
        if (onComplete) onComplete();
        setLoading(false);
      })
      .catch((error) => {
        console.error("Error:", error);
        setLoading(false);
      });
  }, []);

  useEffect(() => {
    getBoard();
  }, []);

  const submit = useCallback(async (field: number, playerId = 1) => {
    setLoading(true);

    await fetch(`/api/board?field=1&playerId=1`, {
      method: "POST",
    })
      .then((response) => response.text())
      .then((result) => {
        console.log("result", result);
        // setBoard(result);
        getBoard();
        if (onComplete) onComplete();
        setLoading(false);
      })
      .catch((error) => {
        console.error("Error:", error);
        setLoading(false);
      });
  }, []);

  return {
    board,
    loading,
    refetch: getBoard,
    update: submit,
  };
};
