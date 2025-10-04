import { FaUserCircle } from "react-icons/fa";
import { useEffect, useState } from "react";
import DropDown from "../dropDown/dropDown";
const UserDropdown = () => {
  const [isOpen, setIsOpen] = useState(false);
  const toggle = () => {
    setIsOpen((prev) => !prev);
  };
  useEffect(() => {
    //How is this going to work?
    //When the user DropDown is active, isOpen is false
    //Check if there is a mouseDown event
    //If mouseDown Event is true and isOpen is true,
    //Then we will need to set the isOpen to false
    //and also remove the
  }, []);
  return (
    <div className="relative">
      <button
        onClick={() => toggle()}
        className="flex items-center text-gray-700 dropdown-toggle dark:text-gray-400 cursor-pointer"
      >
        <span className="mr-3 overflow-hidden rounded-full h-11 w-11">
          <FaUserCircle size={40} />
        </span>

        <span className="block mr-1 font-medium text-theme-sm">Musharof</span>
        <svg
          className={`stroke-gray-500 dark:stroke-gray-400 transition-transform duration-200 ${
            isOpen ? "rotate-180" : ""
          }`}
          width="18"
          height="20"
          viewBox="0 0 18 20"
          fill="none"
          xmlns="http://www.w3.org/2000/svg"
        >
          <path
            d="M4.3125 8.65625L9 13.3437L13.6875 8.65625"
            stroke="currentColor"
            strokeWidth="1.5"
            strokeLinecap="round"
            strokeLinejoin="round"
          />
        </svg>
      </button>
      {isOpen ? <DropDown /> : <></>}
    </div>
  );
};
export default UserDropdown;
