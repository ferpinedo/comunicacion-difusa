import { Component } from "react";
import Link from "next/link";
// import itsImage from "../images/audio.png";
import Layout from "../components/Layout";

// import "../styles/global.css";

export default class extends Component {
  state = {
    input: "",
    message: null,
  };

  componentDidMount() {
    // start listening the channel message
    global.ipcRenderer.on("message", this.handleMessage);
  }

  componentWillUnmount() {
    // stop listening the channel message
    global.ipcRenderer.removeListener("message", this.handleMessage);
  }

  handleMessage = (event, message) => {
    // receive a message from the main process and save it in the local state
    this.setState({ message });
  };

  handleChange = (event) => {
    this.setState({ input: event.target.value });
  };

  handleSubmit = (event) => {
    event.preventDefault();
    global.ipcRenderer.send("message", this.state.input);
    this.setState({ message: null });
  };

  render() {
    return (
      <Layout>
        <div className="content">
          <div className="title">
            <h1>Comunicación difusa</h1>
            <img src="/images/logo.png" />
            <Link href={`/login`}>
              <button>COMENZAR</button>
            </Link>
          </div>
        </div>

        <style jsx>{`
          button {
            background-color: #5c9dc1;
            color: white;
          }
          .content {
            display: flex;
            width: 100%;
            height: 70vh;
            justify-content: center;
            align-items: center;
          }
          .title {
            display: flex;
            flex-direction: column;
            justify-content: center;
          }
        `}</style>
      </Layout>
    );
  }
}
