const speak = (text) => {
  const message = new SpeechSynthesisUtterance(text);
  const voices = speechSynthesis.getVoices();
  message.voice = voices[31];
  message.volume = 1;
  message.pitch = 1;
  message.rate = 1;
  speechSynthesis.speak(message);
};

export default speak;
