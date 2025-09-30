const Footer = () => {
  return (
    <p className="absolute text-sm text-center text-gray-500 bottom-6 dark:text-gray-400">
      &copy; {new Date().getFullYear()} Finance Tracker
    </p>
  );
};

export default Footer;
