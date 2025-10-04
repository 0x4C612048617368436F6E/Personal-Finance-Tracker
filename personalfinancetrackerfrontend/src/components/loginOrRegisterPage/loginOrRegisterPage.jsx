import { useState } from "react";
import { ToastContainer, toast } from "react-toastify";
import axios from "axios";
const LoginOrRegisterPage = (props) => {
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");

  const loginPostConfig = {
    baseURL: "api/login",
  };

  const registerPostConfig = {
    baseURL: "api/register",
  };

  const axiosInstance = axios.create({});

  const postRequestLogin = {};

  const postRequestRegister = {};

  const sendCredentialsAndCheckIfExistLogin = (username, password) => {
    console.log(userName);
    console.log(password);
    if (username.trim()?.length === 0) {
      console.log("Something went wrong");
      return;
    }
  };

  const sendCredentialsAndCheckIfExistRegister = (
    firstName,
    lastName,
    userName,
    email,
    password,
    confirmPassword
  ) => {
    //implement toastify: https://www.npmjs.com/package/react-toastify
    if (
      firstName.trim()?.length === 0 ||
      lastName.trim()?.length === 0 ||
      userName.trim()?.length === 0 ||
      email.trim()?.length === 0 ||
      password.trim()?.length === 0 ||
      confirmPassword.trim()?.length === 0
    ) {
      //for now
      console.log("Something went wrong");
      return;
    }

    //for now
    if (password.trim() != confirmPassword.trim()) {
      console.log("something went wrong");
      return;
    }
    //assuming all is good, we can send request to backend
  };

  return (
    <div class="flex h-[700px] w-full">
      <div class="w-full hidden md:inline-block ml-2">
        <img
          class="h-full"
          src="../../../assets/images/saving.jpg"
          alt="leftSideImage"
        />
      </div>

      <div class="w-full flex flex-col items-center justify-center">
        <form
          class="md:w-96 w-80 flex flex-col items-center justify-center"
          onSubmit={(e) => e.preventDefault()}
        >
          {props.value === "login" ? (
            <h2 class="text-4xl text-gray-900 font-medium">Login in</h2>
          ) : (
            <h2 class="text-4xl text-gray-900 font-medium">Sign up</h2>
          )}

          {props.value === "login" ? (
            <p class="text-sm text-gray-500/90 mt-3">
              Welcome back! Please Log in to continue
            </p>
          ) : (
            <p class="text-sm text-gray-500/90 mt-3">
              Welcome! Please sign up to continue
            </p>
          )}

          <button
            type="button"
            class="w-full mt-8 bg-gray-500/10 flex items-center justify-center h-12 rounded-full cursor-pointer"
          >
            <img
              src="https://raw.githubusercontent.com/prebuiltui/prebuiltui/main/assets/login/googleLogo.svg"
              alt="googleLogo"
            />
          </button>

          <div class="flex items-center gap-4 w-full my-5">
            <div class="w-full h-px bg-gray-300/90"></div>
            {props.value === "login" ? (
              <p class="w-full text-nowrap text-sm text-gray-500/90">
                or sign in with email
              </p>
            ) : (
              <p class="w-full text-nowrap text-sm text-gray-500/90">
                or sign up with email
              </p>
            )}

            <div class="w-full h-px bg-gray-300/90"></div>
          </div>

          {props.value === "login" ? (
            <>
              <div class="flex items-center w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <svg
                  width="16"
                  height="11"
                  viewBox="0 0 16 11"
                  fill="none"
                  xmlns="http://www.w3.org/2000/svg"
                >
                  <path
                    fill-rule="evenodd"
                    clip-rule="evenodd"
                    d="M0 .55.571 0H15.43l.57.55v9.9l-.571.55H.57L0 10.45zm1.143 1.138V9.9h13.714V1.69l-6.503 4.8h-.697zM13.749 1.1H2.25L8 5.356z"
                    fill="#6B7280"
                  />
                </svg>
                <input
                  type="username"
                  placeholder="username"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={userName}
                  onChange={(e) => setUserName(() => e.target.value)}
                />
              </div>

              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <svg
                  width="13"
                  height="17"
                  viewBox="0 0 13 17"
                  fill="none"
                  xmlns="http://www.w3.org/2000/svg"
                >
                  <path
                    d="M13 8.5c0-.938-.729-1.7-1.625-1.7h-.812V4.25C10.563 1.907 8.74 0 6.5 0S2.438 1.907 2.438 4.25V6.8h-.813C.729 6.8 0 7.562 0 8.5v6.8c0 .938.729 1.7 1.625 1.7h9.75c.896 0 1.625-.762 1.625-1.7zM4.063 4.25c0-1.406 1.093-2.55 2.437-2.55s2.438 1.144 2.438 2.55V6.8H4.061z"
                    fill="#6B7280"
                  />
                </svg>
                <input
                  type="password"
                  placeholder="Password"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                />
              </div>
            </>
          ) : (
            <>
              <div class="flex items-center w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <input
                  type="text"
                  placeholder="firstName"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={firstName}
                  onChange={(e) => setFirstName(() => e.target.value)}
                />
              </div>

              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <input
                  type="text"
                  placeholder="lastname"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={lastName}
                  onChange={(e) => setLastName(e.target.value)}
                />
              </div>

              {/**userName */}
              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <input
                  type="text"
                  placeholder="username"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={userName}
                  onChange={(e) => setUserName(e.target.value)}
                />
              </div>

              {/**email */}
              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <svg
                  width="16"
                  height="11"
                  viewBox="0 0 16 11"
                  fill="none"
                  xmlns="http://www.w3.org/2000/svg"
                >
                  <path
                    fill-rule="evenodd"
                    clip-rule="evenodd"
                    d="M0 .55.571 0H15.43l.57.55v9.9l-.571.55H.57L0 10.45zm1.143 1.138V9.9h13.714V1.69l-6.503 4.8h-.697zM13.749 1.1H2.25L8 5.356z"
                    fill="#6B7280"
                  />
                </svg>
                <input
                  type="email"
                  placeholder="email"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                />
              </div>

              {/**password */}
              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <svg
                  width="13"
                  height="17"
                  viewBox="0 0 13 17"
                  fill="none"
                  xmlns="http://www.w3.org/2000/svg"
                >
                  <path
                    d="M13 8.5c0-.938-.729-1.7-1.625-1.7h-.812V4.25C10.563 1.907 8.74 0 6.5 0S2.438 1.907 2.438 4.25V6.8h-.813C.729 6.8 0 7.562 0 8.5v6.8c0 .938.729 1.7 1.625 1.7h9.75c.896 0 1.625-.762 1.625-1.7zM4.063 4.25c0-1.406 1.093-2.55 2.437-2.55s2.438 1.144 2.438 2.55V6.8H4.061z"
                    fill="#6B7280"
                  />
                </svg>
                <input
                  type="password"
                  placeholder="password"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                />
              </div>
              {/**confirm password */}
              <div class="flex items-center mt-6 w-full bg-transparent border border-gray-300/60 h-12 rounded-full overflow-hidden pl-6 gap-2">
                <svg
                  width="13"
                  height="17"
                  viewBox="0 0 13 17"
                  fill="none"
                  xmlns="http://www.w3.org/2000/svg"
                >
                  <path
                    d="M13 8.5c0-.938-.729-1.7-1.625-1.7h-.812V4.25C10.563 1.907 8.74 0 6.5 0S2.438 1.907 2.438 4.25V6.8h-.813C.729 6.8 0 7.562 0 8.5v6.8c0 .938.729 1.7 1.625 1.7h9.75c.896 0 1.625-.762 1.625-1.7zM4.063 4.25c0-1.406 1.093-2.55 2.437-2.55s2.438 1.144 2.438 2.55V6.8H4.061z"
                    fill="#6B7280"
                  />
                </svg>
                <input
                  type="password"
                  placeholder="confirm password"
                  class="bg-transparent text-gray-500/80 placeholder-gray-500/80 outline-none text-sm w-full h-full"
                  required
                  value={confirmPassword}
                  onChange={(e) => setConfirmPassword(e.target.value)}
                />
              </div>
            </>
          )}

          {props.value === "login" ? (
            <div class="w-full flex items-center justify-between mt-8 text-gray-500/80">
              <div class="flex items-center gap-2">
                <input class="h-5" type="checkbox" id="checkbox" />
                <label class="text-sm" for="checkbox">
                  Remember me
                </label>
              </div>
              <a class="text-sm underline" href="#">
                Forgot password?
              </a>
            </div>
          ) : (
            <></>
          )}
          {props.value === "login" ? (
            <>
              <button
                type="submit"
                class="mt-8 w-full h-11 rounded-full text-white bg-gradient-to-tr from-indigo-600 to-indigo-400 transition-opacity cursor-pointer"
                onClick={() =>
                  sendCredentialsAndCheckIfExistLogin(userName, password)
                }
              >
                Login
              </button>
              <p class="text-gray-500/90 text-sm mt-4">
                Don’t have an account?{" "}
                <a class="text-indigo-400 hover:underline" href="#">
                  Sign up
                </a>
              </p>
            </>
          ) : (
            <>
              <button
                type="submit"
                class="mt-8 w-full h-11 rounded-full text-white bg-gradient-to-tr from-indigo-600 to-indigo-400 transition-opacity cursor-pointer"
                onClick={() =>
                  sendCredentialsAndCheckIfExistRegister(
                    firstName,
                    lastName,
                    userName,
                    email,
                    password,
                    confirmPassword
                  )
                }
              >
                Sign up
              </button>
              <p class="text-gray-500/90 text-sm mt-4">
                Already have an account?{" "}
                <a class="text-indigo-400 hover:underline" href="#">
                  Login in
                </a>
              </p>
            </>
          )}
        </form>
      </div>
    </div>
  );
};

export default LoginOrRegisterPage;
