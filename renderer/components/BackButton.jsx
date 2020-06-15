import Link from "next/link";
import BackIcon from "../public/icons/back.svg";
import MenuIcon from "../public/icons/menu.svg";

const BackButton = ({ type = "back", route }) => (
  <Link href={route}>
    <a className="m-5 cursor-pointer absolute bottom-0">
      {type === "back" ? (
        <BackIcon width="40px" height="40px" fill="#5C9DC1" />
      ) : (
        <MenuIcon width="40px" height="40px" fill="#5C9DC1" />
      )}
    </a>
  </Link>
);

export default BackButton;
