import React, { useCallback, useEffect, useState } from "react";
import { FieldType } from "../components/tictac-toe/board/Field";

export const useField = (onComplete?: () => void) => {
  const [field, setField] = useState<FieldType>();
  const [loading, setLoading] = useState(false);

  const updateField = useCallback(
    async (fieldId: number, boardId: number, sign: string) => {
      setLoading(true);

      try {
        const response = await fetch(
          `/api/fields?boardId=${boardId}&fieldId=${fieldId}&sign=${sign}`,
          {
            method: "POST",
          }
        );
        const field = await response.json();

        if (field) setField(field);
        if (onComplete) onComplete();
        setLoading(false);
      } catch (error) {
        console.error("Error:", error);
        setLoading(false);
      }
    },
    []
  );

  return {
    updateField,
    loading,
  };
};
