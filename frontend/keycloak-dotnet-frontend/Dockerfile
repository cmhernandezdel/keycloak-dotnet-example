FROM node:22-alpine AS build

WORKDIR /app

COPY ./package*.json .

RUN npm install

FROM node:22-alpine AS runtime
WORKDIR /app
COPY . .
COPY --from=build /app/node_modules /app/node_modules

CMD ["npm", "start"]