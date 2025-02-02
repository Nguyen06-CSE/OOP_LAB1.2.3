using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int soMenu = 30;
            int chon;
            List<int> ds = new List<int>();
            NhapNgauNhien(ds, 10);

            do
            {
                XuatMenu();
                chon = ChonMenu(soMenu);
                XuLyMenu(chon, ref n, ds);
            } while (chon != 0);


        }


        static void XuatMenu()
        {
            Console.WriteLine("____________________MENU_____________________");
            Console.WriteLine("0.\tthoat khoi chuong trinh ");
            Console.WriteLine("1.\tSắp xếp mảng theo thứ tự tăng dần.\r\n2.\tSắp xếp mảng theo thứ tự giảm dần.\r\n3.\tSắp xếp chỉ các phần tử lẻ theo thứ tự tăng dần, giữ nguyên vị trí các phần tử chẵn.\r\n4.\tTìm phần tử lớn thứ hai trong mảng.\r\n5.\tTìm phần tử nhỏ thứ hai trong mảng.\r\n6.\tTìm cặp phần tử có tổng bằng x.\r\n7.\tTìm phần tử có tổng của các chữ số lớn nhất.\r\n8.\tTìm giá trị lớn nhất nhưng không phải là phần tử cuối cùng.\r\n9.\tTìm tất cả các cặp phần tử có hiệu là số nguyên tố.\r\n10.\tXoá phần tử đầu tiên lớn hơn x.\r\n11.\tChèn phần tử x vào sao cho mảng vẫn tăng dần.\r\n12.\tChèn phần tử x vào đầu mảng.\r\n13.\tXoá tất cả các phần tử có giá trị lớn hơn x.\r\n14.\tXoá tất cả các số nguyên tố trong mảng.\r\n15.\tTìm vị trí đầu tiên của phần tử lớn nhất.\r\n16.\tTìm vị trí của phần tử nhỏ nhất cuối cùng.\r\n17.\tĐếm số lượng phần tử lớn hơn phần tử đứng trước nó.\r\n18.\tĐếm số lượng phần tử nhỏ hơn phần tử đứng sau nó.\r\n19.\tTìm phần tử có giá trị nhỏ nhất nhưng không phải số âm.\r\n20.\tĐếm số lần hoán đổi tối thiểu để sắp xếp mảng.\r\n21.\tTìm phần tử xuất hiện nhiều nhất trong mảng.\r\n22.\tSắp xếp mảng để phần tử lớn nhất nằm ở đầu và phần tử nhỏ nhất nằm cuối.\r\n23.\tXoá phần tử tại vị trí k.\r\n24.\tTìm tất cả các số chẵn liên tiếp có hiệu bằng d.\r\n25.\tTìm vị trí của phần tử nhỏ nhất trong một mảng tăng dần.\r\n26.\tKiểm tra xem hai mảng có chứa phần tử chung hay không.\r\n27.\tTách mảng thành hai mảng con: mảng chẵn và mảng lẻ.\r\n28.\tKiểm tra xem một mảng đã được sắp xếp chưa.\r\n29.\tTìm số chẵn nhỏ nhất lớn hơn một số cho trước.\r\n30.\tTìm phần tử xuất hiện ít nhất trong mảng.\r\n");

        }

        static int ChonMenu(int soMenu)
        {
            int chon;

            do
            {
                Console.Write($"Nhập chọn [0....{soMenu}]: ");
                chon = int.Parse(Console.ReadLine());
                if (chon >= 0 && chon <= soMenu)
                {
                    break;
                }
            } while (true);
            return chon;
        }

        static void XuLyMenu(int chon, ref int n, List<int> ds)
        {
            int x;
            switch (chon)
            {
                case 0:
                    Console.WriteLine("Thoát khỏi chương trình");
                    break;
                case 1:
                    Xuat(ds);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:


                    break;
                case 11:
                    
                    
                    break;
                case 12:
                    
                    
                    break;
                case 13:

                    break;
                case 14:
                    
                    
                    
                    break;
                case 15:

                    break;
                case 16:
                    
                    
                    
                    
                    break;
                case 17:

                    
                    
                    
                    break;

                case 18:
                    
                    
                    
                    break;
                case 19:
                    
                    
                    
                    break;
                case 20:
                    
                    
                    break;
                case 21:
                    
                    
                    
                    break;
                case 22:

                    break;
                case 23:


                    break;
                case 24:
                    
                    
                    
                    break;
                case 25:
                    
                    
                    
                    break;
                case 26:
                    
                    
                    
                    
                    
                    break;
                case 27:

                    break;
                case 28:



                    break;
                case 29:

                    break;


                case 30:

                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        static void Nhap(List<int> ds)
        {
            Console.WriteLine("nhap so phan tu");
            var dem = int.Parse(Console.ReadLine());
            for (int i = 0; i < dem; i++)
            {
                Console.Write("nhap vao phan tu thu {0}: ", i); // Sử dụng Console.Write thay vì Console.WriteLine
                ds.Add(int.Parse(Console.ReadLine()));
            }
        }

        static void NhapNgauNhien(List<int> ds, int k)
        {

            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                ds.Add(random.Next(10));
            }
        }

        static void Xuat(List<int> ds)
        {
            foreach (int i in ds)
            {
                Console.Write($"{i}" + '\t');
            }
            Console.WriteLine();
        }

        static List<int> DaoNguoc(List<int> ds)
        {
            List<int> list = new List<int>();
            for(int i = ds.Count - 1; i >= 0; i--)
            {
                list.Add(ds[i]);
            }

            return list;
        }

        static List<int> XoaCacPTTrungNhau(List<int> ds)
        {
            List<int> res = new List<int>();
            for(int i = 0 ; i < ds.Count ; i++)
            {
                if(!res.Contains(ds[i])) res.Add(ds[i]);
            }
            return res;
        }


        static List<int> MangChiaHetCho3(List<int> ds)
        {
            List<int> res = new List<int>();
            foreach (int num in ds)
            {
                if (num % 3 == 0) res.Add(num);
            }
            return res;
        }

        static int TongLonNhatDayCon(List<int> ds)
        {
            int maxSum = ds[0], currentSum = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                currentSum = Math.Max(ds[i], currentSum + ds[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }


        static int DemDayConCoTongBangS(List<int> ds, int S)
        {
            int count = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < ds.Count; j++)
                {
                    sum += ds[j];
                    if (sum == S) count++;
                }
            }
            return count;
        }

        static bool CoBaPhanTuLienTiepTongX(List<int> ds, int x)
        {
            for (int i = 0; i < ds.Count - 2; i++)
            {
                if (ds[i] + ds[i + 1] + ds[i + 2] == x) return true;
            }
            return false;
        }





        static List<(int, int)> DemSoLanXuatHien(List<int> ds)
        {
            List<(int, int)> result = new List<(int, int)>();
            List<int> uniqueNumbers = XoaCacPTTrungNhau(ds);

            foreach (int num in uniqueNumbers)
            {
                int dem = 0;
                foreach (int i in ds)
                {
                    if (i == num)
                    {
                        dem++;
                    }
                }
                result.Add((num, dem));
            }

            return result;
        }

        

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static List<List<int>> TimDayConCoTongNguyenTo(List<int> ds)
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < ds.Count; i++)
            {
                int sum = 0;
                List<int> subArray = new List<int>();
                for (int j = i; j < ds.Count; j++)
                {
                    sum += ds[j];
                    subArray.Add(ds[j]);
                    if (LaSoNguyenTo(sum)) result.Add(new List<int>(subArray));
                }
            }
            return result;
        }


        static void UpdateMaxSub(List<int> currentSub, ref List<int> maxSub)
        {
            if (currentSub.Count > maxSub.Count)
            {
                maxSub = new List<int>(currentSub); 
            }
        }

        static List<int> DayConToanChanDaiNhat(List<int> ds)
        {
            List<int> maxSub = new List<int>(), currentSub = new List<int>();
            foreach (int num in ds)
            {
                if (num % 2 == 0) currentSub.Add(num);  
                else currentSub.Clear();  

                UpdateMaxSub(currentSub, ref maxSub); 
            }
            return maxSub;
        }

        static int DoDaiDayTangDaiNhat(List<int> ds)
        {
            if (ds.Count == 0) return 0;  

            int maxLen = 1, currentLen = 1;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] > ds[i - 1])  
                {
                    currentLen++;  
                }
                else
                {
                    currentLen = 1;  
                }

                maxLen = FindMax(currentLen, maxLen);  
            }
            return maxLen;
        }

        static int FindMax(int a, int b)
        {
            return a > b ? a : b;  
        }







    }
}
