FROM node:14 as build
WORKDIR /src
COPY package*.json ./
RUN npm install
COPY ./ ./
RUN npm run build --prod

FROM nginx:alpine
WORKDIR /app
COPY --from=build /src/dist/my-frontend /usr/share/nginx/html
