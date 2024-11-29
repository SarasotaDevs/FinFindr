import axios from 'axios';
import { API_URL } from '../../config/APIKeys';
export async function createUser(userData) {
  try {
    const response = await axios.post(`${process.env.API_ENDPOINT}/users`, userData);
    return response.data;
  } catch (error) {
    console.error('Error creating user:', error);
    throw error;
  }
}

export async function test() {
    try {
      console.log(API_URL);
      const userId = "123";
      const response = await axios.get(`${API_URL}/api/client/getfinance/${userId}`);
      console.log(response.data);
      return response.data;
    } catch (error) {
      console.error('Error creating user:', error);
      throw error;
    }
  }
