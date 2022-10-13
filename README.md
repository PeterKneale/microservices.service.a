# microservices.service.a


- Run the published microservice
```sh
docker run \
  --name chassis_service_a \
  -e SERVICE:FILE=//app/ServiceB.dll \
  -e SERVICE:ContentRootPath=//app \
  -p 5000:5000/tcp \
  -p 5001:5001/tcp \
  peterkneale/peterkneale.microservices.a 
```
