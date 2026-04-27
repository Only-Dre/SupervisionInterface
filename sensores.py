import json
import paho.mqtt.client as mqtt
import random
import time

BROKER = "localhost"
PORT = 1883
TOPIC = "industria/sensores"

dados = {
    "temperatura":(20, 90),
    "umidade": (30, 90),
    "pressao": (1.0, 10.0),
    "vibracao": (1.0, 10.0),
    "nivel": (0, 100)
}

def gerar_dados():
    return {
        "temperatura": round(random.uniform(*dados["temperatura"]), 1),
        "umidade": round(random.uniform(*dados["umidade"]), 1),
        "pressao": round(random.uniform(*dados["pressao"]), 2),
        "vibracao": round(random.uniform(*dados["vibracao"]), 1),
        "nivel": round(random.uniform(*dados["nivel"]), 1),
    }

# Conecta o brocker 
def on_connect(client, userdata, flags, rc):
    print(f"Conectado{rc}")
    if rc != 0:
        print("Erro ao conectar")

def main():
    client = mqtt.Client()
    client.on_connect = on_connect

    try:
        client.connect(BROKER, PORT, keepalive=60)
    except Exception as e:
        print(f"Erro ao conectar: {e}")
        return

    client.loop_start()  # Inicia loop em segundo plano para manter a conexão

    while True:
        dados = gerar_dados()
        payload = json.dumps(dados)
        client.publish(TOPIC, payload)
        print(f"Publicado: {payload}")
        time.sleep(2)

if __name__ == "__main__":
    main()