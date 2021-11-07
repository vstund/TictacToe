import React from "react";
import { Board } from "./board/Board";

export interface ITictacToeProps {}

export const TictacToe: React.FC<ITictacToeProps> = () => {
  return (
    <div>
      <div>Hello World 'TictacToe'!</div>
      <Board />
    </div>
  );
};
