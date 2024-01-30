import 'package:flutter/material.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Adso',
      home: Scaffold(
        appBar: AppBar(
          backgroundColor: const Color.fromARGB(255, 56, 163, 35),
          title: const Text('Gestion De Mantenimiento'),
        ),
        body: Center(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Row(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Container(
                      child: Icon(
                        Icons.chair,
                        color: Colors.white,
                      ),
                      width: 250,
                      height: 150,
                      decoration: BoxDecoration(
                          image: DecorationImage(
                              fit: BoxFit.cover, image: NetworkImage('')),
                          color: Color.fromARGB(255, 56, 163, 35),
                          borderRadius: BorderRadius.circular(10),
                          boxShadow: [
                            BoxShadow(
                                color: const Color.fromARGB(255, 56, 163, 35),
                                blurRadius: 3)
                          ]),
                    ),
                    SizedBox(
                      width: 20,
                    ),
                    Container(
                      child: Icon(
                        Icons.document_scanner,
                        color: Colors.white,
                      ),
                      width: 250,
                      height: 150,
                      decoration: BoxDecoration(
                          image: DecorationImage(
                              fit: BoxFit.cover, image: NetworkImage('')),
                          color: Color.fromARGB(255, 56, 163, 35),
                          borderRadius: BorderRadius.circular(10),
                          boxShadow: [
                            BoxShadow(
                                color: const Color.fromARGB(255, 56, 163, 35),
                                blurRadius: 3)
                          ]),
                    ),
                    SizedBox(
                      width: 20,
                    ),
                    Container(
                      child: Icon(
                        Icons.document_scanner,
                        color: Colors.white,
                      ),
                      width: 250,
                      height: 150,
                      decoration: BoxDecoration(
                          image: DecorationImage(
                              fit: BoxFit.cover, image: NetworkImage('')),
                          color: Color.fromARGB(255, 56, 163, 35),
                          borderRadius: BorderRadius.circular(10),
                          boxShadow: [
                            BoxShadow(
                                color: const Color.fromARGB(255, 56, 163, 35),
                                blurRadius: 3)
                          ]),
                    ),
                    SizedBox(
                      width: 20,
                    ),
                    Container(
                      child: Icon(
                        Icons.gavel,
                        color: Colors.white,
                      ),
                      width: 250,
                      height: 290,
                      color: const Color.fromARGB(255, 56, 163, 35),
                    )
                  ]),
              SizedBox(
                height: 20,
              ),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Container(
                    width: 250,
                    height: 150,
                    color: const Color.fromARGB(255, 56, 163, 35),
                  ),
                  SizedBox(
                    width: 20,
                  ),
                  Container(
                    child: Icon(
                      Icons.document_scanner,
                      color: Colors.white,
                    ),
                    width: 250,
                    height: 150,
                    decoration: BoxDecoration(
                        image: DecorationImage(
                            fit: BoxFit.cover, image: NetworkImage('')),
                        color: Color.fromARGB(255, 56, 163, 35),
                        borderRadius: BorderRadius.circular(10),
                        boxShadow: [
                          BoxShadow(
                              color: const Color.fromARGB(255, 56, 163, 35),
                              blurRadius: 3)
                        ]),
                  ),
                  SizedBox(
                    width: 20,
                  ),
                  Container(
                    child: Icon(
                      Icons.document_scanner,
                      color: Colors.white,
                    ),
                    width: 250,
                    height: 150,
                    decoration: BoxDecoration(
                        image: DecorationImage(
                            fit: BoxFit.cover, image: NetworkImage('')),
                        color: Color.fromARGB(255, 56, 163, 35),
                        borderRadius: BorderRadius.circular(10),
                        boxShadow: [
                          BoxShadow(
                              color: const Color.fromARGB(255, 56, 163, 35),
                              blurRadius: 3)
                        ]),
                  ),
                  SizedBox(
                    width: 20,
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
