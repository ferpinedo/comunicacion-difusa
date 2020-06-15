import SpeakButton from "../components/SpeakButton";
import Layout from "../components/Layout";
import WipIcon from "../public/icons/wip.svg";
import BackButton from "../components/BackButton";

const WipScreen = ({ backRoute = "/categories" }) => (
  <Layout>
    <div className="flex w-full h-full justify-center items-center">
      <div className="flex flex-col items-center space-y-20 my-8">
        <h1>Trabajo en progreso</h1>
        <WipIcon width="100%" height="200px" />
      </div>
    </div>
    <BackButton type="menu" route="/categories" />
    <SpeakButton text="Trabajo en progreso." />
  </Layout>
);

export default WipScreen;
