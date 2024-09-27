import { useAuth0 } from 'react-native-auth0';

export const useAuth = () => {
  // const { authorize } = useAuth0();

  // const login = async () => {
  //   try {
  //     await authorize({ scope: 'openid profile email' }); // Add necessary parameters
  //   } catch (e) {
  //     console.log(e);
  //   }
  // };

  const login = async () => {
    console.log("login")
  }

  return { login };
};
