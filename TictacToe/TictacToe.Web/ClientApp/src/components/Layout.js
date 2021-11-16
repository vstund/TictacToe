import React, { Component } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "./NavMenu";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div className="cc">
        <NavMenu />
        <Container style={{ width: "100%", height: "100%" }}>
          {this.props.children}
        </Container>
      </div>
    );
  }
}
