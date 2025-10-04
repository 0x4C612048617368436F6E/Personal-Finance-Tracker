import GridShape from "../gridShape/gridShape";
import globalStore from "../../store/globalStore";
import PiggyBank from "../piggyBank/piggyBank";

const SplashScreen = () => {
  const handleOnClick = (e) => {
    e.preventDefault();
  };
  return (
    <div className="relative flex flex-col items-center min-h-screen p-6 overflow-hidden z-1 bg-gray-100 dark:bg-gray-900">
      {/* Background grid */}
      <GridShape />
      <div className="absolute inset-0 opacity-10 pointer-events-none">
        <div className="w-full h-full bg-grid-slate-200 dark:bg-grid-slate-700" />
      </div>

      {/* Title */}
      <h1 className="mb-8 font-bold text-gray-800 text-3xl sm:text-4xl dark:text-white/90">
        {globalStore?.splash_Screen}
      </h1>

      {/* PiggyBank visual */}
      <div className="mb-8 w-[400px] h-[400px] sm:w-[500px] sm:h-[500px] rounded-2xl flex items-center justify-center font-bold text-2xl shadow-lg bg-white dark:bg-gray-800">
        <PiggyBank className="w-full h-full" />
      </div>

      {/* Description */}
      <p className="mb-12 text-base text-gray-700 dark:text-gray-400 sm:text-lg text-center max-w-xl">
        {globalStore?.splash_Screen_des}
      </p>

      {/* Action buttons */}
      <div className="flex gap-4">
        <button
          type="button"
          className="px-8 py-3 rounded-lg text-white bg-gray-900 bg-gradient-to-tr from-indigo-600 to-indigo-400 font-medium shadow-md"
        >
          Login
        </button>
        <button
          type="button"
          className="px-8 py-3 rounded-lg text-indigo-600 bg-white border border-indigo-600 hover:bg-indigo-50 transition-colors font-medium shadow-md"
        >
          Sign Up
        </button>
      </div>
    </div>
  );
};

export default SplashScreen;
