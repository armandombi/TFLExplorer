import React from "react";
import Message from "./Message";

export default class Jumbotron extends React.Component {
  render() {
    return (
      <section className="jumbotron text-center">
          <Message /> 
      </section>
    );
  }
}
