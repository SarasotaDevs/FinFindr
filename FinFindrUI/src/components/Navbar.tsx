import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Box from '@mui/material/Box';

const Navbar = () => {
    
  return (
    <>
      <AppBar position="static">
        <Toolbar>
          <Typography variant="h6" component="a" 
         href="/"  sx={{ flexGrow: 1 }}>
            FinFindr
          </Typography>
          <Box sx={{ display: { xs: 'none', sm: 'block' } }}> {/* Hidden on small screens */}
            <Button  href="/wallet" color="inherit">Wallet</Button>
          </Box>
        </Toolbar>
      </AppBar>
    </>
  );
};

export default Navbar;
