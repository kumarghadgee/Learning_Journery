FROM node:22
WORKDIR /app
COPY . .
RUN npm install
EXPOSE 3000
# if no env var DB_HOST given using "-e" it will consider as "localhost".
# since mysql not running in backend's container, this will NOT work.
ENV DB_HOST=localhost
ENV DB_USER=root
ENV DB_PASSWORD=manager
ENV DB_NAME=store
CMD ["node", "server.js"]
