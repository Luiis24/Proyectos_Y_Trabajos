import 'package:flutter/material.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Adso',
      home: Scaffold(
        appBar: PreferredSize(
          preferredSize: Size.fromHeight(60.0),
          child: AppBar(
            backgroundColor: const Color.fromARGB(255, 56, 163, 35),
            title: const Text('Luis Morales'),
            elevation: 0,
          ),
        ),
        body: SingleChildScrollView(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              SingleChildScrollView(
                scrollDirection: Axis.horizontal,
                child: Row(
                  children: [
                    Container(
                      width: 250,
                      height: 150,
                      color: Colors.blue,
                      margin: const EdgeInsets.symmetric(horizontal: 20),
                    ),
                    Container(
                      width: 250,
                      height: 150,
                      color: Colors.red,
                      margin: const EdgeInsets.symmetric(horizontal: 20),
                    ),
                    Container(
                      width: 250,
                      height: 150,
                      color: Colors.green,
                      margin: const EdgeInsets.symmetric(horizontal: 20),
                    ),
                  ],
                ),
              ),
              SizedBox(height: 20),
              Container(
                width: double.infinity,
                height: 150,
                color: Colors.yellow,
                margin: const EdgeInsets.symmetric(vertical: 20, horizontal: 10),
              ),
              SizedBox(height: 20),
              Container(
                width: double.infinity,
                height: 150,
                color: Colors.purple,
                margin: const EdgeInsets.symmetric(vertical: 20, horizontal: 20),
              ),
              SizedBox(height: 20),
              Container(
                width: double.infinity,
                height: 150,
                color: Colors.orange,
                margin: const EdgeInsets.symmetric(vertical: 20, horizontal: 40),
              ),
              SizedBox(height: 20),
              Container(
                width: double.infinity,
                height: 150,
                color: Colors.red,
                margin: const EdgeInsets.symmetric(vertical: 20, horizontal: 10),
              ),
              SizedBox(height: 20),
            ],
          ),
        ),
      ),
    );
  }
}
