const Button = (props) => {
  return (
    <button class="rounded-md bg-gray-900 px-3 py-2 text-sm font-medium text-white cursor-pointer">
      <span class="absolute -inset-1.5"></span>
      <span class="sr-only">{props.value}</span>
      <a
        href="#"
        aria-current="page"
        className={`rounded-md ${props.backgroundColor} px-3 py-2 text-sm font-medium text-white`}
      >
        {props.value}
      </a>
    </button>
  );
};

export default Button;
