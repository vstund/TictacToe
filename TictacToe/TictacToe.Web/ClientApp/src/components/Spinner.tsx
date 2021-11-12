import React from "react";

export interface ISpinnerProps {}

export const Spinner: React.FC<ISpinnerProps> = () => {
  return (
    <div className="spinner-border" role="status">
      <span className="sr-only">Loading...</span>
    </div>
  );
};
