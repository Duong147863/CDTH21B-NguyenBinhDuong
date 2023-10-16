import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';
import 'package:shoe_ocean/bottom_nav.dart';
import 'package:shoe_ocean/drawer_menu.dart';

class ProfileScreen extends StatelessWidget {
  const ProfileScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Image.asset(
          'root/assets/img/logo.png',
          fit: BoxFit.contain,
          height: 75,
        ),
        actions: <Widget>[
          Padding(
            padding: const EdgeInsets.only(right: 50),
            child: IconButton(
              icon: const Icon(Icons.search),
              onPressed: () {},
            ),
          ),
        ],
      ),
      body: Center(
        child: Column(
          children: [
            Row(
              children: [
                Column(
                  children: [
                    Container(
                      padding: const EdgeInsets.only(top: 20),
                      height: 100,
                      width: 100,
                      child: const CircleAvatar(
                        backgroundImage: AssetImage('root/assets/img/avt.jpg'),
                      ),
                    ),
                  ],
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Row(
                      children: [
                        Container(
                          padding: const EdgeInsets.only(top: 20),
                          child: const Text("Neyi"),
                        ),
                      ],
                    ),
                    Row(
                      children: [
                        Container(
                          padding: const EdgeInsets.only(top: 20),
                          child: const Text("Thành viên bạc rách"),
                        ),
                      ],
                    ),
                  ],
                ),
              ],
            ),
            Row(
              children: [
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 20),
                  child: const Text(
                    "Đơn hàng",
                    style: TextStyle(
                      fontSize: 18,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 150),
                  child: const Text(
                    "Xem chi tiết đơn hàng",
                    style: TextStyle(
                      fontSize: 12,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20),
                  child: const Icon(Icons.arrow_forward_ios_outlined),
                ),
              ],
            ),
            Row(
              children: [
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 20),
                  child: const Text(
                    "Đã thích",
                    style: TextStyle(
                      fontSize: 18,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 90),
                  child: const Text(
                    "Xem chi tiết các sản phẩm đã thích",
                    style: TextStyle(
                      fontSize: 12,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20),
                  child: const Icon(Icons.arrow_forward_ios_outlined),
                ),
              ],
            ),
            Row(
              children: [
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 20),
                  child: const Text(
                    "Đã xem gần đây",
                    style: TextStyle(
                      fontSize: 18,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 215),
                  child: const Icon(Icons.arrow_forward_ios_outlined),
                ),
              ],
            ),
            Row(
              children: [
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 20),
                  child: const Text(
                    "Đánh giá cá nhân",
                    style: TextStyle(
                      fontSize: 18,
                    ),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.only(top: 20, left: 205),
                  child: const Icon(Icons.arrow_forward_ios_outlined),
                ),
              ],
            ),
          ],
        ),
      ),
      bottomNavigationBar: const BottomNavigator(index: 2),
      drawer: DrawerMenu(),
    );
  }
}
