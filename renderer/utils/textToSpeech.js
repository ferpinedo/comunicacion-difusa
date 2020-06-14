const speak = (text) => {
  const message = new SpeechSynthesisUtterance(text);
  const voices = speechSynthesis.getVoices();
  console.log("Available voices");
  console.log(voices);
  message.voice = voices[31];
  message.volume = 1;
  message.pitch = 1;
  message.rate = 1;
  speechSynthesis.speak(message);
};

export default speak;
// VOICES
// Paulina, es-MX, 31
// Juan, es-MX, 15
// Jorge, es-ES, 14
// Mónica, es-ES, 29
