

map_numbers = {}
for n in range(2010):
    number = pow(n, 2)
    if "0" not in str(number):
        sorted_number = ''.join(sorted(str(number)))
        if sorted_number not in map_numbers:
            map_numbers[sorted_number] = [number]
        else:
            map_numbers[sorted_number].append(number)


map_valid = {}
for key, val in map_numbers.items():
    if len(val) >= 2 and len(val) <= 5:
        map_valid[key] = val

# print(map_valid)

map_tree = {}
map_tree[2] = []
map_tree[3] = []
map_tree[4] = []
map_tree[5] = []
for key, val in map_valid.items():
    map_tree[len(val)].append([int(key), val])

# print(map_tree)



def next_perfectsq_perm1(lower_limit, k):
    map_squares = {2: [[144, [144, 441]], [256, [256, 625]], [1369, [1369, 1936]], [1467, [1764, 4761]], [11236, [11236, 21316]], [12679, [12769, 96721]], [14488, [14884, 48841]], [24469, [24649, 24964]], [25567, [27556, 75625]], [24589, [29584, 54289]], [34569, [34596, 45369]], [34668, [36864, 86436]], [23446, [42436, 43264]], [45666, [46656, 66564]], [14589, [51984, 95481]], [24579, [74529, 79524]], [56899, [98596, 99856]], [112225, [112225, 212521]], [113569, [113569, 591361]], [113368, [118336, 383161]], [133569, [133956, 933156]], [136789, [139876, 391876]], [124488, [142884, 848241]], [144567, [147456, 447561]], [122458, [148225, 521284]], [146899, [148996, 894916]], [144459, [154449, 594441]], [123556, [155236, 355216]], [144666, [166464, 646416]], [112678, [167281, 817216]], [144679, [169744, 976144]], [137889, [173889, 793881]], [124477, [174724, 474721]], [115567, [175561, 755161]], [114489, [191844, 194481]], [116899, [198916, 919681]], [122256, [216225, 622521]], [224667, [224676, 627264]], [222556, [225625, 265225]], [222579, [227529, 522729]], [223389, [233289, 328329]], [123679, [237169, 729316]], [123448, [238144, 434281]], [124669, [264196, 669124]], [226789, [267289, 287296]], [224478, [272484, 842724]], [234679, [293764, 329476]], [112347, [314721, 741321]], [136699, [316969, 619369]], [123367, [323761, 712336]], [344569, [344569, 659344]], [344457, [345744, 374544]], [344689, [368449, 498436]], [346669, [369664, 649636]], [113689, [398161, 891136]], [124677, [427716, 772641]], [234469, [432964, 964324]], [456679, [456976, 795664]], [445689, [459684, 956484]], [134667, [463761, 736164]], [456678, [467856, 675684]], [112456, [546121, 611524]], [144568, [654481, 844561]], [466789, [667489, 948676]], [667789, [678976, 786769]], [224578, [748225, 874225]], [145678, [758641, 781456]], [126799, [769129, 972196]], [677899, [779689, 877969]], [236799, [799236, 927369]], [335689, [833569, 835396]], [1122345, [1134225, 2134521]], [1134889, [1138489, 1934881]], [1134567, [1153476, 3154176]], [1125556, [1155625, 1552516]], [1127889, [1172889, 1798281]], [1124469, [1192464, 2414916]], [1224667, [1227664, 2627641]], [1236789, [1238769, 1382976]], [1244556, [1245456, 1542564]], [1112269, [1261129, 2211169]], [1225566, [1265625, 1625625]], [1223478, [1272384, 3272481]], [1112679, [1279161, 1971216]], [1255689, [1285956, 2518569]], [1226799, [1292769, 2169729]], [1334689, [1338649, 3319684]], [1123479, [1347921, 1397124]], [1235569, [1352569, 2515396]], [1112347, [1371241, 1413721]], [1236778, [1378276, 3728761]], [1134679, [1394761, 1471369]], [1223449, [1423249, 2493241]], [1234566, [1425636, 2653641]], [1445689, [1456849, 1658944]], [1225567, [1522756, 2175625]], [1256679, [1527696, 1726596]], [1233468, [1633284, 3218436]], [1246669, [1669264, 2696164]], [1236799, [1723969, 1923769]], [1222579, [1729225, 2927521]], [1256778, [1758276, 2178576]], [1124667, [1766241, 2461761]], [1567789, [1787569, 1857769]], [1336788, [1838736, 3837681]], [1122358, [1852321, 2531281]], [1125889, [1885129, 1985281]], [1126899, [1896129, 1912689]], [1122589, [1918225, 2181529]], [1222489, [2122849, 2829124]], [1123468, [2163841, 3161284]], [1246678, [2166784, 2876416]], [1123369, [2193361, 3129361]], [1234468, [2316484, 3644281]], [2223567, [2322576, 2673225]], [2223556, [2325625, 2356225]], [2334478, [2334784, 3378244]], [1233556, [2353156, 3352561]], [2344456, [2365444, 2534464]], [1122346, [2421136, 3211264]], [2445589, [2455489, 2598544]], [2346778, [2483776, 3678724]], [1245699, [2499561, 2954961]], [1222459, [2524921, 2941225]], [1225678, [2572816, 2825761]], [2233467, [2742336, 3732624]], [1222389, [2812329, 3122289]], [2245689, [2842596, 2965284]], [2334699, [2934369, 3392964]], [1235779, [3157729, 3759721]], [1235668, [3182656, 3682561]], [1344699, [3196944, 3944196]], [1223566, [3225616, 3625216]], [2356789, [3297856, 3857296]], [3444489, [3448449, 3849444]], [1234459, [3541924, 3952144]], [3556699, [3556996, 3659569]], [1123569, [3651921, 3956121]]], 3: [[169, [169, 196, 961]], [1269, [1296, 2916, 9216]], [11466, [11664, 16641, 41616]], [12445, [12544, 44521, 52441]], [12258, [18225, 25281, 81225]], [12367, [23716, 32761, 72361]], [24489, [42849, 49284, 82944]], [113679, [131769, 171396, 197136]], [113467, [137641, 141376, 417316]], [146799, [149769, 471969, 974169]], [134668, [164836, 364816, 481636]], [145669, [165649, 495616, 541696]], [122359, [319225, 923521, 931225]], [123489, [321489, 349281, 381924]], [223578, [378225, 783225, 837225]], [1124566, [1256641, 1466521, 2611456]], [1345689, [1354896, 3481956, 3594816]], [1244569, [1459264, 1592644, 1926544]], [1224567, [1476225, 2125764, 2547216]], [1234489, [1493284, 3214849, 3912484]], [1135678, [1731856, 3118756, 3511876]], [1222578, [1782225, 2752281, 2852721]], [1233469, [1943236, 2343961, 3924361]], [1366789, [1976836, 3786916, 3876961]], [1223469, [2143296, 2196324, 2634129]], [2344489, [2439844, 2849344, 3489424]], [1224679, [2617924, 2647129, 2917264]]], 4: [[16789, [17689, 18769, 78961, 81796]], [112689, [112896, 168921, 281961, 298116]], [123469, [132496, 214369, 346921, 436921]], [134569, [195364, 351649, 395641, 543169]], [123669, [236196, 263169, 269361, 962361]], [1124478, [1127844, 1871424, 2187441, 2471184]], [1146789, [1498176, 1617984, 1671849, 1879641]], [1223568, [1863225, 2368521, 3186225, 3861225]]], 5: [[13468, [16384, 31684, 36481, 38416, 43681]], [1234456, [1236544, 1532644, 1643524, 3254416, 3452164]]]}
    list_of_k = map_squares[k]
    for number_list in list_of_k:
        if lower_limit < number_list[1][-1]:
            return number_list[1][-1]

print(next_perfectsq_perm1(500, 2) == 625)
print(next_perfectsq_perm1(200, 2) == 625)
print(next_perfectsq_perm1(144, 2) == 625)
print(next_perfectsq_perm1(145, 2) == 625)
print(next_perfectsq_perm1(441, 2) == 625)
# print(next_perfectsq_perm(100, 2) == 441)
# print(next_perfectsq_perm(440, 2) == 441)
# print(next_perfectsq_perm(257, 2) == 441)



# print(next_perfectsq_perm(100, 3) == 961)
# print(next_perfectsq_perm(100, 4) == 81796)
# print(next_perfectsq_perm(1000, 3) == 9216)
# print(next_perfectsq_perm(100000, 4) == 298116)

#

def next_perfectsq_perm(lower_limit, k):
    perfect_square = lower_limit
    

