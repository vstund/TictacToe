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

  return {
    board,
    loading,
    refetch: getBoard,
  };
};
