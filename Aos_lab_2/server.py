import socket
import datetime

server = socket.socket(
    socket.AF_INET,
    socket.SOCK_STREAM
)
f = open('text.txt', 'w')
f.write("socket was created :: " + str(datetime.datetime.now()) + "\n")




port = 12345

server.bind(
    ("127.0.0.1", 1234)
)

server.listen()

users = []


def listen_user(user):
    while True:
        data = user.recv(2048)
        decoded_data = data.decode("utf8")
        print(decoded_data)
        if str(decoded_data) == "who":
            user.send("Kostenko Mykola Olegovich, 9 variant".encode("utf8"))
            f.write("command who was executed :: " + str(datetime.datetime.now()) + "\n")

        if str(decoded_data) == "calculate":
            f.write("command calculate was invoked :: " + str(datetime.datetime.now()) + "\n")
            user.send("send message with - + * / in the beginning and then two integers".encode("utf8"))
            expression = user.recv(2048)
            decoded_expression = expression.decode("utf8")
            if(str(parse_calc(decoded_expression)) != "eror"):
                value = str(parse_calc(decoded_expression))
                user.send(value.encode("utf8"))
                f.write("command calculate was successful :: " + str(datetime.datetime.now()) + "\n")

            else:
                user.send("incorrect expression, write calculate again".encode("utf8"))
                f.write("command calculate was not executed :: " + str(datetime.datetime.now()) + "\n")
        elif str(decoded_data) == "save":
            f.close()
        else:
            user.send("incorrect command".encode("utf8"))
            f.write("command was incorrect :: " + str(datetime.datetime.now()) + "\n")



def parse_calc(exp):
    x = exp.split()
    if x[0] == "-":
        a = int(x[1])
        b = int(x[2])
        return a - b
    elif x[0] == "+":
        a = int(x[1])
        b = int(x[2])
        return a + b
    elif x[0] == "*":
        a = int(x[1])
        b = int(x[2])
        return a * b
    elif x[0] == "/":
        a = int(x[1])
        b = int(x[2])
        return a / b
    else:
        return "eror"




def start_server():
    while True:
        user_socket, address = server.accept()
        print(f"User <{address[0]}> connected!")
        users.append(user_socket)
        user_socket.send("you are connected".encode("utf8"))
        f.write(f"User <{address[0]}> connected! :: " + str(datetime.datetime.now()) + "\n")
        listen_user(user_socket)

while True:
    start_server()




