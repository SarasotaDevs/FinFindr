import { Routes, Route } from 'react-router-dom';
import Home from '../pages/Home';


const NavigationRoutes = () => {
  return (
    <>
    <Routes>
        <Route path="/home" element={<Home />} />
    </Routes>
    <Routes>
        <Route path="/" element={<Home />} />
    </Routes>
  </>
  )
}

export default NavigationRoutes