import { useEffect } from "react";
import speak from "../utils/textToSpeech";
import AudioIcon from "../public/icons/audio.svg";

const SpeakButton = ({ text, raw, children }) => {
  useEffect(() => {
    if (!raw) {
      speak(text);
    }
    return () => {
      speechSynthesis.cancel();
    };
  }, []);

  const width = raw ? "30px" : "40px";
  const fill = raw ? "gray" : "#B49ACA";
  return (
    <div
      className={
        "cursor-pointer flex flex-col items-center justify-center " +
        (!raw && " m-5 absolute bottom-0 right-0")
      }
      onClick={() => speak(text)}
    >
      {children}
      <AudioIcon width={width} fill={fill} />
    </div>
  );
};

export default SpeakButton;
