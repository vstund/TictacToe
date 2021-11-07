import React from "react";
import { useBoard } from "../../../hooks/useBoard";

export interface IBoardProps {}

export const Board: React.FC<IBoardProps> = () => {
  const { board } = useBoard();

  return (
    <div>
      <div>Hello World 'Board'!</div>
      {board}
    </div>
  );
};
