import React from "react";
import { useBoard } from "../../../hooks/useBoard";

export interface IBoardProps {}

export const Board: React.FC<IBoardProps> = () => {
  const { board, refetch, update } = useBoard(onCompleted);

  const onClick = async () => {
    await update(1, 1);
  };

  function onCompleted() {
    // refetch();
  }

  return (
    <div>
      <div>Hello World 'Board'!</div>
      {board}
      <div onClick={onClick}>Click me! I should update 1# field.</div>
    </div>
  );
};
