import React, { useState } from "react";
import { IconOSign, IconXSign } from "../../../assets/Icons";
import { useField } from "../../../hooks/useField";
import { Spinner } from "../../Spinner";
import "../../../styles/Field.scss";

export type FieldType = {
  id: number;
  xcoordinate: number;
  ycoordinate: number;
  sign: string;
  boardId: number;
};

export interface IFieldProps {
  field: FieldType;
  isOddTurn: boolean;
  onUpdateCompleted?: () => void;
  onError?: () => void;
}

export const Field: React.FC<IFieldProps> = ({
  field,
  isOddTurn,
  onUpdateCompleted,
  onError,
}) => {
  //   const [sign, setSign] = useState(field.sign);
  const { updateField, loading } = useField(onUpdateCompleted);

  const onFieldClick = async () => {
    const sign = isOddTurn ? "X" : "O";
    await updateField(field.id, field.boardId, sign);
  };

  return (
    <div className="field" onClick={onFieldClick}>
      {loading ?? <Spinner />}
      <div className="field__sign">
        {field.sign === "X" && <IconXSign className="animated fadeIn" />}
        {field.sign === "O" && <IconOSign className="animated fadeIn" />}
      </div>
    </div>
  );
};
