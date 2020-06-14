import Link from "next/link";
import { useEffect } from "react";
import speak from "../utils/textToSpeech";

const SpeakButton = ({ text }) => {
  useEffect(() => {
    console.log("useEffect started");
    // setTimeout(() => {
    speak(text);
    // }, 1000);
  }, []);
  return (
    <button
      className="m-5 mb-20 bg-purple-400 text-gray-900 absolute bottom-0"
      onClick={() => speak(text)}
    >
      Reproducir
    </button>
  );
};

export default SpeakButton;
