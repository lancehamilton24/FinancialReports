import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';





const IndexCard = () => {
    const indices = [{ "name": "Dow Jones" }, { "name": "S&P 500" }, { "name": "Nasdaq" }, { "name": "Russell 2000" }]

    var cardStyle = {
        backgroundColor: "black",
        textAlign: 'center',
        margin: 3,
        width: 250,
        height: 250
    }

    return (
        indices.map((index) => {
            return (
                <div className='indexCard'>
                <Card style={cardStyle}>
                    <CardContent>
                        <Typography sx={{ fontSize: 14 }} color="#76ff03" gutterBottom>
                            {index.name}
                        </Typography>
                    </CardContent>
                </Card>
                </div>
            );
        })
    );
};

export default IndexCard;
