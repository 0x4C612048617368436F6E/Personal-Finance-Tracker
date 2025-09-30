import GridShape from "../gridShape/gridShape";
import globalStore from "../../store/globalStore";
import PiggyBank from "../piggyBank/piggyBank";
import Button from "../button/button";

const SplashScreen = () => {
  const handleOnClick = (e) => {
    e.preventDefault();
  };
  return (
    <div className="relative flex flex-col items-center min-h-screen p-6 overflow-hidden z-1 bg-gray-100">
      {/* Background grid */}
      <GridShape />
      <div className="absolute inset-0 opacity-10 pointer-events-none">
        <div className="w-full h-full bg-grid-slate-200" />
      </div>

      {/* Title */}
      <h1 className="mb-8 font-bold text-gray-800 text-3xl sm:text-4xl dark:text-white/90">
        {globalStore?.splash_Screen}
      </h1>

      {/* PiggyBank visual - now bigger */}
      <div className="mb-8 w-[500px] h-[500px] rounded-2xl flex items-center justify-center font-bold text-2xl shadow-lg">
        <PiggyBank className="w-full h-full" />
      </div>

      {/* Description */}
      <p className="mb-12 text-base text-gray-700 dark:text-gray-400 sm:text-lg text-center">
        {globalStore?.splash_Screen_des}
      </p>

      {/* Action buttons */}
      <div className="">
        <button
          type="submit"
          class="mt-8 h-11 text-white bg-indigo-500 hover:opacity-90 transition-opacity"
        >
          Login
        </button>
      </div>
    </div>
  );
};

export default SplashScreen;
