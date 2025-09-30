import SplashScreen from "./components/splashScreen/splashScreen";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./components/layout/layout";
import ErrorPage from "./components/errorPage/errorPage";
import Login from "./components/login/login";
import Register from "./components/register/register";

const App = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<SplashScreen />} />
          <Route path="login" element={<Login page="login" />} />
          <Route path="register" element={<Register page="register" />} />
          <Route
            path="password-recovery"
            element={<Register page="register" />}
          />
          <Route path="overview" element={<Register page="register" />} />
          <Route path="*" element={<ErrorPage />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
};

export default App;
