# Microservices Full

Bu proje, mikroservis mimarisi ile oluşturulmuş tam donanımlı bir uygulamadır. Projede, çeşitli teknolojiler ve araçlar kullanılarak, ölçeklenebilir ve esnek bir yapı oluşturulmuştur.

## Özellikler

### Kullanılan Teknolojiler

- **.NET 5**: Mikroservislerin oluşturulması.
- **Docker**: Konteynerizasyon ve uygulama dağıtımı.
- **Kubernetes**: Konteyner orkestrasyonu ve yönetimi.
- **gRPC**: Yüksek performanslı iletişim protokolü.
- **SQL**: İlişkisel veri tabanı yönetim sistemi.
- **RabbitMQ**: Mesaj kuyruğu sistemi.
- **NGINX**: Ingress Load Balancer.

## Modüller

- **Platform Servisi**: Mikroservislerin yönetimi.
- **Komut Servisi**: Komutların işlenmesi ve yönetimi.
- **K8S**: Kubernetes konfigürasyonları.

## Kurulum

1. **Depoyu Klonlayın**:
   ```sh
   git clone https://github.com/alikorkmaz03/microsservicesfull.git
   cd microsservicesfull
2. **Docker Compose ile Servisleri Başlatın:**:
    ```sh
    docker-compose up --build
## Kullanım

Projeyi yerel ortamda çalıştırdıktan sonra, aşağıdaki URL'ler üzerinden erişim sağlayabilirsiniz:

Postman konfigürasyonları K8S projesi içinde mevcuttur.Import edebilirsiniz...

- **Platform Servisi**: [http://localhost:5000/platforms](http://localhost:5000/platforms)
- **Komut Servisi**: [http://localhost:6000/commands](http://localhost:6000/commands)

## Katkıda Bulunma

Katkılarınızı bekliyoruz! Pull request oluşturabilir veya sorunları bilidirebilirsiniz.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.


  
