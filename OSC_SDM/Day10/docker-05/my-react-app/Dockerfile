FROM nginx
COPY dist /usr/share/nginx/html
RUN echo ' \
server { \
    listen 80; \
    location / { \
        root /usr/share/nginx/html; \
        try_files $uri /index.html; \
    } \
} ' > /etc/nginx/conf.d/default.conf