import React from 'react';
import { UserProvider } from './context/UserContext';
import Layout from '../routes/Layout';


export default function App() {
  return (
    <UserProvider>
      <Layout />
    </UserProvider>
  );
}

