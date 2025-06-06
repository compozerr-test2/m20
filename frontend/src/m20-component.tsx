import React from "react";

interface Props {
   name: string;
}

const M20Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default M20Component;