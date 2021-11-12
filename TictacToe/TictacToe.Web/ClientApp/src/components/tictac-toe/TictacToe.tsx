import React from "react";
import { Board } from "./board/Board";
import "../../styles/TictacToe.scss";

export interface ITictacToeProps {}

export const TictacToe: React.FC<ITictacToeProps> = () => {
  return (
    <div className="tictac-toe-game">
      <h3>Hello World 'TictacToe'!</h3>
      <br />
      <Board />
    </div>
  );
};
