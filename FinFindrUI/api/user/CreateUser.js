import axios from 'axios';
import { API_URL } from '../../src/config/APIKeys';
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
      const response = await axios.get(`${API_URL}/test`);
      return response.data;
    } catch (error) {
      console.error('Error creating user:', error);
      throw error;
    }
  }
