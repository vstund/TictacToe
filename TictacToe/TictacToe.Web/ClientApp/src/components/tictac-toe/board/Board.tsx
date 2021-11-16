import React, { useState } from "react";
import { useFields } from "../../../hooks/useFields";
import { Field } from "./Field";
import { Spinner } from "../../Spinner";
import "../../../styles/Board.scss";

export type BoardType = {
  id: number;
};

export interface IBoardProps {}

export const Board: React.FC<IBoardProps> = () => {
  const boardId = 1;
  const { fields, loading, refetch } = useFields(boardId);
  const [turn, setTurn] = useState(0);
  const [currentSign, setCurrentSign] = useState();

  function onFieldUpdateCompleted() {
    incrementTurn();
    refetch();
  }

  const incrementTurn = () => {
    setTurn((prevState) => prevState + 1);
  };

  const isOddTurn = () => {
    return turn % 2 === 1;
  };

  return (
    <div className="board">
      {loading ?? <Spinner />}
      {fields?.map((field) => (
        <Field
          key={field.id}
          field={field}
          isOddTurn={isOddTurn()}
          onUpdateCompleted={onFieldUpdateCompleted}
        />
      ))}
    </div>
  );
};
