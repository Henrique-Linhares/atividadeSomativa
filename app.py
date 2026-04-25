import paho.mqtt.client as mqtt
import json
import random
import time

broker = "10.110.18.11"
porta = 1883
topico = "atividade/sensores"

cliente = mqtt.Client()
cliente.connect(broker, porta, 60)

print("Enviando dados para o broker MQTT...")
print("Pressiona Ctrl + C para encerrar.\n")


try:
    while True:
        temperatura = round(random.uniform(20,120), 2)
        umidade = round(random.uniform(30,100), 2)
        pressao = round(random.uniform(1, 15), 1)
        vibracao = round(random.uniform(0, 30), 1)
        nivel = round(random.uniform(0,100), 2)
        
        dados = {
            "temperatura": temperatura,
            "umidade": umidade,
            "pressao": pressao,
            "vibracao": vibracao,
            "nivel": nivel
        }
        
        mensagem = json.dumps(dados)
        
        cliente.publish(topico, mensagem)
        print(f"Mensagem enviada: {mensagem}")
        time.sleep(2)
except KeyboardInterrupt:
    print("\nPrograma encerrado.")
    cliente.disconnect()