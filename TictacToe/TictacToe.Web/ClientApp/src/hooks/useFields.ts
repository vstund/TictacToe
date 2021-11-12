import React, { useCallback, useEffect, useState } from "react";
import { FieldType } from "../components/tictac-toe/board/Field";

export const useFields = (boardId: number = 1, onComplete?: () => void) => {
  const [fields, setFields] = useState<FieldType[]>();
  const [loading, setLoading] = useState(false);

  const getFieldsByBoard = useCallback(async () => {
    setLoading(true);

    try {
      const response = await fetch(`/api/fields?boardId=${boardId}`);
      const fields = await response.json();

      if (fields) setFields(fields);
      if (onComplete) onComplete();
      setLoading(false);
    } catch (error) {
      console.error("Error:", error);
      setLoading(false);
    }
  }, []);

  useEffect(() => {
    getFieldsByBoard();
  }, []);

  return {
    fields,
    loading,
    refetch: getFieldsByBoard,
  };
};
