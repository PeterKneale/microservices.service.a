# microservices.service.a


- Run the published microservice
```sh
docker run \
  --name chassis_service_a \
  -e SERVICE:FILE=//app/ServiceA.dll \
  -e SERVICE:ContentRootPath=//app \
  -p 6000:5000/tcp \
  -p 6001:5001/tcp \
  peterkneale/peterkneale.microservices.a 
```
