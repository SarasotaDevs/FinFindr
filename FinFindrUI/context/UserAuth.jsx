import React, { createContext, useState } from 'react';

export const UserAuth = createContext();

// Create a Provider Component
export const UserAuthProvider = ({ children }) => {
  const [userName, setUser] = useState("");

  return (
    <UserAuth.Provider value={{ userName, setUser }}>
      {children}
    </UserAuth.Provider>
  );
};
