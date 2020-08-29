## Mongodb Wrapper Serivce

A generic controller controls all the basic CRUD and find options.

For every domain object we can create a collection in mondb and wrap an API around it by just adding a controller and the corresponding configurations.

### NOTES

- `docker-compose up --build` to build and start the containers
- connnection string for the mongodb is `mongodb://<container name>:<container port>` eg:, `mongodb://mongo:27017`