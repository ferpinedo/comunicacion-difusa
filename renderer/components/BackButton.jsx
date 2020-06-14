import Link from "next/link";

const BackButton = ({ type = "back", route }) => (
  <Link href={route}>
    <button className="m-5 bg-white text-gray-900 absolute bottom-0">
      Volver
    </button>
  </Link>
);

export default BackButton;
