FROM node:16-stretch AS build
WORKDIR /build
COPY . /build
RUN npm install
RUN npm run build

FROM nginx:1.20
COPY --from=build /build/dist/app /usr/share/nginx/html
COPY /nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80