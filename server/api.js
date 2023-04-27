fetch('https://api.ipify.org?format=json')
  .then(response => response.json())
  .then(data => {
    const userIp = data.ip;
    fetch(`https://freegeoip.app/json/${userIp}`)
      .then(response => response.json())
      .then(data => {
        console.log(`Your location: ${data.city}, ${data.region_name}, ${data.country_name}`);
      })
      .catch(error => console.error(error));
  })
  .catch(error => console.error(error));


  // using this we will display the price of the object in that currency