import NavigationBar from "../navigationBar/navigationBar";
import Footer from "../footer/footer";
import { Outlet } from "react-router-dom";
import LoggedInUserNavigationBar from "../loggedInUserNavigationBar/loggedInUserNavigationBar";
const Layout = () => {
  return (
    <>
      {/*<NavigationBar />*/}
      <LoggedInUserNavigationBar />
      <main className="flex-grow">
        <Outlet />
      </main>
    </>
  );
};
export default Layout;
