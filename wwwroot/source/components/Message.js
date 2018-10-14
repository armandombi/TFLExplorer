import * as React from "react";

export default class Message extends React.Component {
  constructor(props) {
    super(props);
    this.state = { message: "" };
    this.handleChange = this.handleChange.bind(this);
  }
  handleChange(event) {
    this.setState({ message: event.target.value });
  }
  render() {
    return (
      <div class="container">
        <h1 className="jumbotron-heading">{this.state.message}</h1>
        <p className="lead text-muted">
          <div className="input-group mb-3">
            <div className="input-group-prepend">
              <span className="input-group-text" id="basic-addon1">
                Enter a message:
              </span>
            </div>
            <input
              type="text"
              className="form-control"
              placeholder="Type Something"
              aria-label="Username"
              aria-describedby="basic-addon1"
              value={this.state.message}
              onChange={this.handleChange}
            />
          </div>
        </p>
      </div>
    );
  }
}
