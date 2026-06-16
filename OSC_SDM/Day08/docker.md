# docker

## installation

### linux

```bash

# ubuntu
# update apt repository
> sudo apt-get update

# install ca-certificates (Certificate Authority) and keys required to access the apt repository for docker
> sudo apt-get install ca-certificates curl
> sudo install -m 0755 -d /etc/apt/keyrings
> sudo curl -fsSL https://download.docker.com/linux/ubuntu/gpg -o /etc/apt/keyrings/docker.asc
> sudo chmod a+r /etc/apt/keyrings/docker.asc

# Add the repository to Apt sources
> echo \
  "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.asc] https://download.docker.com/linux/ubuntu \
  $(. /etc/os-release && echo "${UBUNTU_CODENAME:-$VERSION_CODENAME}") stable" | \
  sudo tee /etc/apt/sources.list.d/docker.list > /dev/null
> sudo apt-get update

# install docker community edition (docker-ce)
> sudo apt-get install docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin

```

### windows

- download and install windows docker desktop
- https://docs.docker.com/desktop/setup/install/windows-install/

### macOs

- download and install macOS docker desktop
- https://docs.docker.com/desktop/setup/install/mac-install/

## generic docker commands

```bash

# get list of an object
> docker <object> ls

# get details of selected object
> docker <object> inspect <object name or id>

# remove selected object
> docker <object> rm <object name or id>

```

## images

```bash

# get the list of images
> docker image ls

# download an image from docker image registry
# https://hub.docker.com
# > docker image pull <image name>
> docker image pull httpd
> docker image pull nginx
> docker image pull mysql
> docker image pull node
> docker image pull mongo

# get details of docker image
# > docker image inspect <image name>
> docker image inspect httpd

# remove the selected image
# > docker image rm <image name>
> docker image rm httpd

```

## building a custom image

- a custom image can be built using a file named Dockerfile
- Dockerfile is a special file which contains the commands to build an image
- every command must have a parameter associated with it
- every image must have a base image
- all commands must be written in uppercase
- commands
  - FROM
    - used to set the base image
    - the image can be built using only one base image
  - COPY
    - used to copy resource(s) from local machine to image
    - syntax:
      - COPY <local machine path> <image path>
    - e.g.
      - COPY index.html /usr/local/apache2/htdocs
  - EXPOSE
    - used to expose a port number
  - WORKDIR
    - used to set a working directory
    - if the working directory does not exist, it gets created first
    - e.g. WORKDIR /src
  - RUN
    - used to execute command(s) at the time of building the image
    - this command will be executed only once
    - e.g. RUN npm install
  - CMD
    - used to execute the command at the time of running the container
    - it must be the last command in the Dockerfile
    - only one CMD is allowed per image
    - e.g. CMD node server.js

```bash

# build the image
# if tag name is not used, by default image uses tag named 'latest'
# > docker image build -t <image name>:<tag name> <build context>
> docker image build -t mywebsite .

```

## containers

```bash

# get the list of running containers
> docker container ls

# get the list of all containers (running (Up) / stopped (Exited) / created)
> docker container ls -a

# create a container
# every container has a unique id and unique name
> docker container create <image name>
> docker container create httpd

# start a created/stopped container
# note:
# - to test the web server container's output
#   - curl <container ip address>
# - to get the ip address of a container
#   - docker container inspect <container id> | grep IPAddress
> docker container start <container name or id>

# run a container in attached mode
# - first create a new container and start it immediately
# - run = create + start
# - attached mode
#   - the container gets attached with the terminal or shell in which it is running
#   - if the terminal stops, the container also stops
> docker container run <image name or id>

# run a container in detached mode (background)
# detached mode
# - the container gets detached from the terminal
# - even if the terminal exits, the container still runs in background
> docker container run -d <image name>

# run a container with following parameters
# -d: runs the container in detached mode
# --name: assigns a name to the container
# --rm: used to create temporary container which will get removed when stopped
# -p: used for port forwarding
# -e: used to set an environment variable
# -v: used to mount volumes
> docker container run -d --name <container name> <image name>

# get the details of selected container
> docker container inspect <container name or id>

# stop a running container
> docker container stop <container name or id>

# remove a stopped container
> docker container rm <container name or id>

# remove a running container
> docker container rm --force <container name or id>

# get the logs generated by a container
> docker container logs <container name or id>

# execute a command inside a container
# > docker container exec <container name or id> <command>
> docker container exec mysql date

# get a shell from a container
# -i: interactive (you can pass input to the container)
# -t: get the terminal from the container
# > docker container exec -it <container name or id> <sh/bash>

```

## container examples

```bash

# run a container for httpd with name myhttpd
# > docker container run -d --name <container name> <image name>
> docker container run -d --name myhttpd httpd

# run httpd container with port forwarding from 8001 to 80
# > docker container run -d --name <container name> -p <os port>:<container port> <image name>
# port number
# - is an integer (1 - 65535) which is assigned to a process
# - used by the OS or users to communicate with the process
# - types
#   - standard ports
#     - reserved ports
#       - port numbers 1 to 1024 are reserved for protocols
#       - e.g. http (80), https (443), telnet (23), ftp (20, 21), smtp (25), ssh (22), dns (53)
#     - e.g. mysql (3306), mongodb (27017)
#   - ephemeral ports (>1024)
#     - non-standard ports
#     - used by any application
> docker container run -d --name httpd -p 8001:80 httpd

# create mysql container with required environment variable(s)
# > docker container run -d --name <container name> -p <os port>:<container port> -e <env variable>=<value> <image name>
> docker container run -d --name mysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=root mysql

```

## volumes

## network
