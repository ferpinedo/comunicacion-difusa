import Link from "next/link";
import { useEffect } from "react";
import speak from "../utils/textToSpeech";
import AudioIcon from "../public/icons/audio.svg";

const SpeakButton = ({ text }) => {
  useEffect(() => {
    speak(text);
    return () => {
      // speechSynthesis.pause();
      speechSynthesis.cancel();
    };
  }, []);
  return (
    <a
      className="m-5 cursor-pointer absolute bottom-0 right-0"
      onClick={() => speak(text)}
    >
      <AudioIcon width="40px" fill="#B49ACA" />
    </a>
  );
};

export default SpeakButton;
