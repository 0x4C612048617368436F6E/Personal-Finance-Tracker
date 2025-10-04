const OverView = () => {
  return (
    <div className="flex min-h-screen bg-gray-50 text-gray-800">
      {/* Sidebar */}

      {/* Main Content */}
      <div className="flex-1 bg-white rounded-l-3xl shadow-lg p-8 flex flex-col">
        {/* Header */}
        <div className="flex justify-between items-center mb-10">
          <div className="flex items-center gap-4">
            <div>
              <h2 className="text-4xl font-bold bg-gradient-to-r from-indigo-900 to-indigo-600 bg-clip-text text-transparent flex items-center gap-2">
                Greetings! <i className="bx bxs-hand text-yellow-400"></i>
              </h2>
              <p className="text-gray-500 text-sm">FirstName LastName</p>
            </div>
          </div>

          <div className="flex gap-6 items-center">
            <div className="relative">
              <input
                type="text"
                placeholder="Search transactions, cards, etc."
                className="pl-12 pr-4 py-3 rounded-full bg-gray-100 focus:ring-2 focus:ring-indigo-400 shadow-sm outline-none w-80"
              />
              <i className="bx bx-search absolute left-4 top-1/2 -translate-y-1/2 text-gray-400 text-lg"></i>
            </div>
            <div className="flex items-center gap-2 px-6 py-3 rounded-full bg-gradient-to-tr from-indigo-600 to-indigo-400 text-white font-medium shadow-md cursor-pointer hover:shadow-lg">
              <i className="bx bx-user-circle text-xl"></i>
              <span>My account</span>
              <i className="bx bx-chevron-down"></i>
            </div>
          </div>
        </div>

        {/* Content Area */}
        <div className="flex gap-10 flex-1">
          {/* Left Panel */}
          <div className="flex-1 flex flex-col gap-10">
            {/* Cards Section */}
            <div>
              <div className="flex justify-between items-center mb-4">
                <h3 className="text-xl font-bold relative pl-4 before:absolute before:left-0 before:top-1/2 before:-translate-y-1/2 before:w-1 before:h-5 before:rounded p-3">
                  Cards
                </h3>
                <span className="text-indigo-600 text-sm font-semibold cursor-pointer hover:text-indigo-800">
                  See all →
                </span>
              </div>
              <div className="flex gap-6">
                <div className="flex-1 h-48 p-6 rounded-xl shadow-lg bg-gradient-to-br from-indigo-800 to-indigo-600 text-white flex flex-col justify-between cursor-pointer hover:scale-105 transition">
                  <div className="flex justify-end">
                    <i className="bx bx-dots-vertical-rounded"></i>
                  </div>
                  <div className="text-2xl font-semibold">£ 21,540.8</div>
                  <div className="flex items-center gap-2 text-sm">
                    **** 2475 <i className="bx bx-low-vision"></i>
                  </div>
                  <div className="flex justify-between text-sm">
                    <span>10/25</span>
                    <i className="bx bxl-visa text-2xl"></i>
                  </div>
                </div>
                <div className="flex-1 h-48 p-6 rounded-xl shadow-lg bg-gradient-to-br from-slate-600 to-slate-800 text-white flex flex-col justify-between cursor-pointer hover:scale-105 transition">
                  <div className="flex justify-end">
                    <i className="bx bx-dots-vertical-rounded"></i>
                  </div>
                  <div className="text-2xl font-semibold">£ 185,632.0</div>
                  <div className="flex items-center gap-2 text-sm">
                    **** 3854 <i className="bx bx-low-vision"></i>
                  </div>
                  <div className="flex justify-between text-sm">
                    <span>10/25</span>
                    <i className="bx bxs-circle text-2xl"></i>
                  </div>
                </div>
              </div>
            </div>

            {/* Quick Actions */}
            <div className="flex gap-6">
              {[
                { icon: "bx-transfer", label: "Transfer", primary: true },
                { icon: "bx-bulb", label: "Utility" },
                { icon: "bx-dollar-circle", label: "Taxes" },
                { icon: "bx-car", label: "Transport" },
              ].map(({ icon, label, primary }, idx) => (
                <div
                  key={idx}
                  className={`flex flex-col items-center justify-center gap-2 flex-1 py-4 rounded-xl shadow-md cursor-pointer hover:shadow-lg ${
                    primary
                      ? "bg-gradient-to-tr from-indigo-600 to-indigo-400 text-white"
                      : "bg-gray-100 text-gray-700"
                  }`}
                >
                  <div className="text-2xl">
                    <i className={`bx ${icon}`}></i>
                  </div>
                  <span className="text-sm font-semibold">{label}</span>
                </div>
              ))}
            </div>
          </div>

          {/* Right Panel */}
          <div className="flex-[0.8] bg-gradient-to-b from-gray-50 to-gray-200 rounded-xl p-6 shadow-md">
            <div className="flex justify-between items-center mb-6">
              <h3 className="text-lg font-semibold flex items-center gap-2">
                Statistics <i className="bx bx-info-circle text-gray-400"></i>
              </h3>
              <div className="flex items-center gap-1 px-3 py-1 bg-gray-100 rounded-lg text-sm cursor-pointer">
                <span>This week</span>
                <i className="bx bx-chevron-down"></i>
              </div>
            </div>
            {/* Donut Chart Placeholder */}
            <div className="relative flex justify-center items-center h-40">
              <svg viewBox="0 0 100 100" className="w-32 h-32">
                <circle
                  cx="50"
                  cy="50"
                  r="40"
                  className="fill-none stroke-gray-200 stroke-[10]"
                />
                <circle
                  cx="50"
                  cy="50"
                  r="40"
                  className="fill-none stroke-indigo-500 stroke-[10]"
                  strokeDasharray="60 40"
                  strokeDashoffset="0"
                />
                <circle
                  cx="50"
                  cy="50"
                  r="40"
                  className="fill-none stroke-indigo-300 stroke-[10]"
                  strokeDasharray="40 60"
                  strokeDashoffset="60"
                />
              </svg>
              <div className="absolute text-center">
                <div className="text-xs text-gray-500">Total</div>
                <div className="font-bold">$16,480.00</div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default OverView;
