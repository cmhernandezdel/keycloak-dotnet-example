import { Button, Grid } from '@mui/material';
import { useKeycloak } from '@react-keycloak/web';

const Landing = () => {
    const { keycloak } = useKeycloak();

    const login = () => {
        keycloak.login();
    }

    return (
        <Grid container spacing={2}>
            <Grid item xs={4}>
                <Button variant="contained" onClick={login}>Login</Button>
            </Grid>
            <Grid item xs={4}>
                
            </Grid>
            <Grid item xs={4}>
                
            </Grid>
        </Grid>
    );
}

export default Landing;