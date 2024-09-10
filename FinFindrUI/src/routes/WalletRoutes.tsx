import { Routes, Route } from 'react-router-dom';
import Wallet from '../pages/Home';


const WalletRoutes = () => {
  return (
    <>
    <Routes>
        <Route path="/wallet" element={<Wallet />} />
    </Routes>
  </>
  )
}

export default WalletRoutes